# JsonParser:

There are many popular implementations of JSON Parser, but at this point in time, none of them can give me information about duplicate properties. All of them silently ignore the duplicates. This implementation saves information about duplicate properties and gives the implementor option to throw or ignore. 

Anyone who has need to do some custom validation like in my case can re-use this code rather than going from scratch. i hope it helps someone.



