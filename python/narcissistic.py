def narcissistic( value ):
    strInt = str(value)
    return value==sum([int(i)**len(strInt) for i in strInt])
