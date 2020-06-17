def valid_parentheses(string):
    count = 0
    for p in string:
        if count < 0: return False
        if p == "(": count += 1
        elif p == ")": count -= 1
    return count == 0
