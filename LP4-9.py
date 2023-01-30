import random
snumber = int(input("Enter a number between 1 and 20: "))
cnumber = random.randint(1, 20)
print("Player's Number: " + str(snumber))
print("Computer's Number: " + str(cnumber))
if snumber == cnumber:
  print("You Won!")
else:
  print("Better Luck Next Time.")