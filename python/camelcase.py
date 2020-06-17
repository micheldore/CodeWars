def to_camel_case(text):
    prev = False
    finalString = ""
    
    for c in text:
        if c == "-" or c == "_":
            prev = True
            continue
        elif prev: 
            finalString += c.upper() 
            prev = False
        else:
            finalString += c
    return finalString
