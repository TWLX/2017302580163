<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h2>Order List</h2>
        <table border ="1">
          <tr bgcolor="#9acd32">
            <th align="left">Name</th>
            <th align="left">ID</th>
            <th align="left">Num</th>
            <th align="left">Good</th>
          </tr>
          <xsl:for-each select="ArrayOfOrder/Order">
            <tr>
              <td>
                <xsl:value-of select="Name"/></td>
              <td>
                <xsl:value-of select="ID"/>
              </td>
              <td>
                <xsl:value-of select="Num"/>
              </td>
              <td>
                <xsl:value-of select="Good"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
