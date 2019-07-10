import pyodbc

_driver = 'SQL Server Native Client 11.0'
_server = 'wkfgdbservice.chinanorth.cloudapp.chinacloudapi.cn,1433'  
_user = 'sa'
_password = 'rootL123456789'
_database = 'test'
    
#表
def select(tab):
     conn = pyodbc.connect(driver=_driver, server=_server, user=_user, password=_password, database=_database)
     cur = conn.cursor()
     sql = "select * from %s"%tab
     cur.execute(sql)
     rows = cur.fetchall()
     cur.close()
     conn.close()
     return rows   #list
    
#表、要执行的内容
def insert(table,str):
     conn = pyodbc.connect(driver=_driver, server=_server, user=_user, password=_password, database=_database)
     cur = conn.cursor()
     sql = "insert into %s"%table + " values('%s')"%str
     cur.execute(sql)
     conn.commit()
     cur.close()
     conn.close()

def delete(table,lie,str):
     conn = pyodbc.connect(driver=_driver, server=_server, user=_user, password=_password, database=_database)
     cur = conn.cursor()
     sql = "delete from %s"%table + " where %s"%lie +" = '%s'"%str
     cur.execute(sql)
     conn.commit()
     cur.close()
     conn.close()

def update(table,lie,oldStr,newStr):
     insert(table,newStrtr)
     delete(table,lie,oldStr)
