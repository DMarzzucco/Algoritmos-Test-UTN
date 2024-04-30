# Fibonacci
limit=20
n1=0
n2=1
# print(n1)
# print(n2)
while n2<limit:
    i=n1+n2
    # print(i)
    n1=n2
    n2=i
    
# funcines de destructuramiento
def huevos():
    return('izquierdo', 'derecho')
meChupaUnHuevoIzquierdo, meChupaUnHuevoDerecho = huevos()
print(meChupaUnHuevoIzquierdo)
# print(meChupaUnHuevoDerecho)