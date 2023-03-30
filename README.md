# FormatNames

***!!!THIS ONLY WORKS ON .TXT FILES DO NOT RUN ON ANY OTHER FILE TYPE OR THE FILE WILL BE CORRUPTED AND DATA LOST!!!***


I just make apps to automate repetitive tasks that I run across at work.

One thing that is annoying is when people send me lists of names in different formats. 

ie. 
- firstname lastname
- lastname, firstname
- etc.

I want this program to make it consistent so I can sort it / check for duplicates / etc. 

//psudo code..
```
program needs to go through all of the lines of data
while(file.nextLine().exists)
  string input = file.nextline
  if input.contains (",")
    input.split(",")
    store data somewhere
    modify / reverse that data so it presents first last
    delete current line from the file
    add new line to the file
```


Questions..
* can you delete data and write data on the file concurrently? does that mess anything up? 
* replace line instead?
* Or store ALL data then write to a new file?
