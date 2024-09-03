<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="xml" indent="yes" cdata-section-elements="text"/>
    <!-- Identity transform -->
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>
    <xsl:template match="/">
        <FileSet>
            <FileSetFiles>
                <FileSetFile>
                    <RelativePath>trim-demo-flow.xml</RelativePath>
                    <FileContents>
                        <xsl:apply-templates select="*"/>
                    </FileContents>
                </FileSetFile>
            </FileSetFiles>
        </FileSet>
    </xsl:template>
    <!-- Remove elements with values starting with 'rec' and 17 characters long -->
    <xsl:template match="*[string-length() = 17][starts-with(., 'rec')]"/>
    <!-- Generic template for elements with 'Attachments' in their name and have a child 'thumbnails' node -->
    <xsl:template match="*[contains(name(), 'Attachments')][thumbnails]">
        &lt;<xsl:value-of select="name()"/> json:Array="true"&gt;
        <url><xsl:value-of select="url"/></url>
        &lt;/<xsl:value-of select="name()"></xsl:value-of>&gt;
    </xsl:template>

    <xsl:template match="text()[contains(., '&amp;')]">
        &lt;![CDATA[<xsl:value-of select="." />]]&gt;
    </xsl:template>
</xsl:stylesheet>