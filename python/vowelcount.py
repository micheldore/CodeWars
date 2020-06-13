def get_count(input_str):
    num_vowels = 0
    for c in ['a','e','i','o','u']: num_vowels+=input_str.count(c)
    
    return num_vowels
