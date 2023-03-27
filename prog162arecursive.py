def fact(n):
  if n == 1:
    return n
  return n * fact(n-1)

def main():
  num = int(input("Enter a number: "))
  while num != 0:
    factn = fact(num)
    print(f"{num} != {factn}")
    num = int(input("Enter a number: "))

if __name__ == "__main__":
  main()