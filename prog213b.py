num1 = int(input("Enter quantity: "))
itemprice = 0.0

if num1 > 0 and num1 <= 99:
  itemprice = 5.95
if num1 > 99 and num1 <= 199:
  itemprice = 5.75
if num1 > 199 and num1 <= 299:
  itemprice = 5.40
if num1 > 300:
  itemprice = 5.15

num2 = float(num1 * itemprice)

print("Price: " + str(itemprice))
print("Amount due: " + str(num2))