def countBits(n):
    return len(bin(n)[2:].replace('0',''))
