<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="text" indent="yes"/>
	<xsl:template match="books">
	<xsl:text>Review of 3.5: </xsl:text>
			<xsl:value-of select="count(book[ review = 3.5])" />
	<xsl:element name="br"></xsl:element>
	<xsl:text>Review of 4: </xsl:text>
			<xsl:value-of select="count(book[ review = 4 ])" />		
	</xsl:template>
</xsl:stylesheet>
