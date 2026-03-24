import random

def ntnho(n):
    if n < 2:
        return False
    if n == 2 or n == 3:
        return True
    if n % 2 == 0:
        return False
    i = 3
    while i * i <= n:
        if n % i == 0:
            return False
        i += 2
    return True

def miller(n, k=10):
    if n < 2:
        return False
    if n == 2 or n == 3:
        return True
    if n % 2 == 0:
        return False

    r = 0
    d = n - 1
    while d % 2 == 0:
        d //= 2
        r += 1

    for _ in range(k):
        a = random.randrange(2, n - 1)
        x = pow(a, d, n)

        if x == 1 or x == n - 1:
            continue

        for __ in range(r - 1):
            x = pow(x, 2, n)
            if x == n - 1:
                break
        else:
            return False

    return True

def lant(n):
    if n < 10**6:
        return ntnho(n)
    return miller(n, 15)

def sole(bits):
    n = random.getrandbits(bits)
    n |= (1 << (bits - 1))
    n |= 1
    return n

def taont(bits):
    while True:
        x = sole(bits)
        if lant(x):
            return x

def muoint():
    m = (1 << 89) - 1
    ds = []
    x = m - 2
    while len(ds) < 10:
        if lant(x):
            ds.append(x)
        x -= 2
    return ds

def ktnt(n):
    gh = (1 << 89) - 1
    if n >= gh:
        return None
    return lant(n)

def ucln(a, b):
    while b != 0:
        a, b = b, a % b
    return abs(a)

def mumod(a, x, p):
    kq = 1
    a %= p
    while x > 0:
        if x % 2 == 1:
            kq = (kq * a) % p
        a = (a * a) % p
        x //= 2
    return kq

def menu():
    while True:
        print("\n===== LAB 02 =====")
        print("1. Tao so nguyen to 8-bit, 16-bit, 64-bit")
        print("2. Tim 10 so nguyen to lon nhat nho hon 2^89 - 1")
        print("3. Kiem tra so < 2^89 - 1 co phai nguyen to khong")
        print("4. Tim UCLN cua 2 so nguyen lon")
        print("5. Tinh a^x mod p")
        print("0. Thoat")

        chon = input("Chon: ")

        if chon == "1":
            print("NT 8-bit :", taont(8))
            print("NT 16-bit:", taont(16))
            print("NT 64-bit:", taont(64))

        elif chon == "2":
            ds = muoint()
            print("10 so nguyen to lon nhat nho hon 2^89 - 1:")
            for i in range(len(ds)):
                print(i + 1, ":", ds[i])

        elif chon == "3":
            n = int(input("Nhap n: "))
            kq = ktnt(n)
            if kq is None:
                print("n phai nho hon 2^89 - 1")
            elif kq:
                print("La so nguyen to")
            else:
                print("Khong phai so nguyen to")

        elif chon == "4":
            a = int(input("Nhap a: "))
            b = int(input("Nhap b: "))
            print("UCLN =", ucln(a, b))

        elif chon == "5":
            a = int(input("Nhap a: "))
            x = int(input("Nhap x: "))
            p = int(input("Nhap p: "))
            print("Ket qua =", mumod(a, x, p))

        elif chon == "0":
            break

        else:
            print("Chon sai")

if __name__ == "__main__":
    menu()