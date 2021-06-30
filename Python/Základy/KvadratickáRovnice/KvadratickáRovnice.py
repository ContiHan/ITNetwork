print("Program na výpočet kvadratické rovnice")
print("Tvar rovnice: ax^2+bx+c=0")

a = int(input("Zadej koeficient a: "))
b = int(input("Zadej koeficient b: "))
c = int(input("Zadej koeficient c: "))

D = (b**2) - (4 * a * c)

if (a == 0):
    print("Není kvadratická rovnice")
elif (D == 0):
    x = (-b) / (2 * a)
    print("Kvadratická rovnice má jeden kořen x =", x)
elif (D > 0):
    x1 = ((-b) + (D**(1/2))) / (2 * a)
    x2 = ((-b) - (D**(1/2))) / (2 * a)
    print("Kvadratická rovnice má dva kořeny x1 =", x1, "a x2 =", x2)
elif (D < 0):
    print("Rovnice nemá v obotu rálných čísel řešení")