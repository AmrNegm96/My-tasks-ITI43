<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="CATALOG">
		  <h2>My CD Collection</h2>
		  <table border="1">
			<tr bgcolor="#9acd32">
			  <th style="text-align:left">Title</th>
			  <th style="text-align:left">Artist</th>
			</tr>
			<xsl:for-each select="CD">
			<xsl:sort data-type="number" order="descending" select="PRICE">
			</xsl:sort>
				<tr>
				  <td><xsl:value-of select="TITLE"/></td>
				  <td><xsl:value-of select="ARTIST"/></td>
				  <td><xsl:value-of select="PRICE"/></td>
				</tr>
			</xsl:for-each>
		  </table>
	</xsl:template>
</xsl:stylesheet>


