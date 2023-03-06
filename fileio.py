lines = ["Hello, ", "World", "!"]

with open("data/myfile.txt", "w") as f:
  f.write("Hi \n")
  f.writelines(lines)

with open("data/myfile.txt", "r") as f:
  print(f.read())