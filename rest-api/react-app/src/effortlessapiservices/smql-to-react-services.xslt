<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
                >
    <xsl:output method="xml" indent="yes"/>
    <xsl:include href="../CommonXsltTemplates.xslt"/>
    <xsl:param name="output-filename" select="'output.txt'" />
    <xsl:variable name="odxml" select="document('DataSchema.odxml')"/>

    <xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="/*">
        <FileSet>
            <FileSetFiles>
                <xsl:for-each select="/*/SMQActors/SMQActor"><xsl:variable name="actor" select="."/>
                    <FileSetFile>
                        <RelativePath>
                            <xsl:value-of select="concat(Name, 'Service.js')"/>
                        </RelativePath>
                        <xsl:element name="FileContents" xml:space="preserve">
import BaseService from './BaseService';

class <xsl:value-of select="concat(Name, 'Service')"/> extends BaseService {
    <xsl:for-each select="ActorCanSay/SMQMessageKey"><xsl:for-each select="/*/SMQMessages/SMQMessage[SMQMessageKey=current()]">
        <xsl:variable name="msg" select="."/><xsl:variable name="od" select="$odxml//ObjectDefs/ObjectDef[Name = $msg/RAWValues/Response or Name = $msg/RAWValues/Payload]" />
    <xsl:choose>
    <xsl:when test="$msg/RAWValues/Category='Custom'">
    async <xsl:value-of select="$msg/Name" />(payload) { 
        return this.apiCall("POST", "<xsl:value-of select="$actor/Name"/>", "<xsl:value-of select="$msg/Name" />", null, payload); // <xsl:value-of select="$od/Name"/></xsl:when>
    <xsl:when test="$msg/RAWValues/Category='CRUD' and substring($msg/Name, 1, 3) = 'Get'">
    async <xsl:value-of select="$msg/Name" />(view) { 
        return this.apiCall("GET", "<xsl:value-of select="$actor/Name"/>", "<xsl:value-of select="$od/PluralName" />", view, null); // <xsl:value-of select="$od/Name"/></xsl:when>
    <xsl:when test="$msg/RAWValues/Category='CRUD' and substring($msg/Name, 1, 3) = 'Add'">
    async <xsl:value-of select="$msg/Name" />(<xsl:value-of select="$od/Name"/>) { 
        return this.apiCall("POST", "<xsl:value-of select="$actor/Name"/>", "<xsl:value-of select="$od/Name" />", null, <xsl:value-of select="$od/Name"/>); // <xsl:value-of select="$od/Name"/></xsl:when>
    <xsl:when test="$msg/RAWValues/Category='CRUD' and substring($msg/Name, 1, 6) = 'Update'">
    async <xsl:value-of select="$msg/Name" />(<xsl:value-of select="$od/Name"/>) {
        return this.apiCall("PUT", "<xsl:value-of select="$actor/Name"/>", "<xsl:value-of select="$od/Name" />", null, <xsl:value-of select="$od/Name"/>); // <xsl:value-of select="$od/Name"/></xsl:when>
    <xsl:when test="$msg/RAWValues/Category='CRUD' and substring($msg/Name, 1, 6) = 'Delete'">
    async <xsl:value-of select="$msg/Name" />(id) { 
        return this.apiCall("DELETE", "<xsl:value-of select="$actor/Name"/>", "<xsl:value-of select="$od/Name" />", null, id); // <xsl:value-of select="$od/Name"/></xsl:when>
</xsl:choose>
   }
    
    </xsl:for-each></xsl:for-each>
}

export default new <xsl:value-of select="concat(Name, 'Service')"/>();                        </xsl:element>
                    </FileSetFile>                    
                </xsl:for-each>
                <FileSetFile>
                    <RelativePath>
                        <xsl:text>BaseService.js</xsl:text>
                    </RelativePath>
                    <xsl:element name="FileContents" xml:space="preserve">// services/BaseService.js
class BaseService {
    async apiCall(method = "GET", controller = "User", endpoint = "AppUsers", view = "Grid%20view", payload = null, airtableWhere) {
      try {
        const token = localStorage.getItem("access_token");
        if (!token &amp;&amp; endpoint !== "exchange") {
          return null;
        }
  
        airtableWhere = airtableWhere ? `&amp;airtableWhere=${airtableWhere}` : '';
        view = view ? `&amp;view=${view}` : '';
  
        var url = `https://localhost:42016/${controller}/${endpoint}?${view}${airtableWhere}`;
        if (method == "DELETE") {
          url = `https://localhost:42016/${controller}/${endpoint}?id=${payload}`;
        } 

        const response = await fetch(url, {
          method: method,
          headers: { "Content-Type": "application/json", Authorization: `Bearer ${token}` },
          body: payload ? JSON.stringify(payload) : null,
        });
  
        if (!response.ok) {
          throw new Error(`Failed to ${method} ${endpoint} ${JSON.stringify(response)}`);
        }
  
        return await response.json();
      } catch (ex) {
        console.error('Error: ', ex);
      }
    }
  }
  
  export default BaseService;
  
</xsl:element>
                </FileSetFile>
            </FileSetFiles>
        </FileSet>
    </xsl:template>
</xsl:stylesheet>
