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
                    <RelativePath>trimmed-mof-data.xml</RelativePath>
                    <FileContents>
                        <xsl:apply-templates select="*"/>
                    </FileContents>
                </FileSetFile>
            </FileSetFiles>
        </FileSet>
    </xsl:template>

     <!-- Template for MOFChoices -->
     <xsl:template match="//MOFChoices">
     <MOFChoices>
        <xsl:apply-templates select="ParentChoiceName"/>
        <xsl:apply-templates select="NodeName"/>
         <xsl:apply-templates select="FQNChoiceName"/>
         <xsl:apply-templates select="Name"/>
         <xsl:apply-templates select="MOFLayerNumber"/>
         <xsl:apply-templates select="ParentMOFLayerNumber"/>
         <xsl:apply-templates select="NodeDesiredColor"/>
         <xsl:apply-templates select="ParentNodeDesiredColor"/>
         <xsl:apply-templates select="MixedColor"/>
         <xsl:apply-templates select="ExpectedColor"/>
         <xsl:apply-templates select="IsInSync"/>
         <xsl:apply-templates select="IsInSyncImage"/>
         <xsl:apply-templates select="NodeAttachments"/>
         <xsl:apply-templates select="ParentNodeAttachments"/>
         <xsl:apply-templates select="ToolAttachments"/>
         <xsl:apply-templates select="ToolInputAttachments"/>
         <xsl:apply-templates select="ToolInputChoiceNodeAttachments"/>
         <xsl:apply-templates select="*[not(self::Name or self::ExpectedColor or self::MixedColor or self::NodeName or self::FQNChoiceName or self::ParentChoiceName or self::MOFLayerNumber or self::ParentMOFLayerNumber or self::NodeDesiredColor or self::ParentNodeDesiredColor or self::IsSyntaxFree or self::IsInSync or self::IsInSyncImage or self::NodeAttachments or self::ParentNodeAttachments or self::ToolAttachments or self::ToolInputAttachments or self::ToolInputChoiceNodeAttachments)]"/>
        <xsl:apply-templates select="IsSyntaxFree"/>
    </MOFChoices>
 </xsl:template>

    <xsl:template match="//MOFNodes">
        <MOFNodes>
            <xsl:apply-templates select="NodeName"/>
            <xsl:apply-templates select="NodeType"/>
            <xsl:apply-templates select="NodeDefaultFileName"/>
            <xsl:apply-templates select="DesiredColor"/>
            <xsl:apply-templates select="SortOrder"/>
            <xsl:apply-templates select="Attachments"/>
            <xsl:apply-templates select="PlatformAttachments"/>
            <xsl:apply-templates select="OutputIsDocs"/>
            <xsl:apply-templates select="OutputIsCode"/>
            <xsl:apply-templates select="*[name() != 'NodeName' and name() != 'NodeType' and name() != 'NodeDefaultFileName' and name() != 'SortOrder' and name() != 'DesiredColor' and name() != 'Attachments' and name() != 'PlatformAttachments' and name() != 'OutputIsDocs' and name() != 'OutputIsCode']"/>
        </MOFNodes>
    </xsl:template>

    <xsl:template match="//MOFLayers">
        <MOFLayers>
            <xsl:apply-templates select="Name"/>
            <xsl:apply-templates select="*[name() != 'Name']"/>
        </MOFLayers>
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