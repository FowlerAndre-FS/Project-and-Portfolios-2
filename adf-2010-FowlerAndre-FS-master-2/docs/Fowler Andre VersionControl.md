# Instructions 
Update this document where indicated (brackets). Replace text inside the brackets with your own information. For example: Course Name should be the name of this course, and not the generic words "Course Name".

**Note:** As you complete each item, also update reference links where indicated below. 

<br>


* **[ Version Control & Workflow ]**
* **[ Andre Fowler ]**
* **[ 11/30/2020 ]**

This paper addresses some of the topic matter covered in research and activity this week. Be sure to include reference links below to the research and information you used to complete this assignment.

## Topic: Terminal
Professional developers use Terminal daily. It's essential to understand some fundamental commands to use the application. 

Update the information below to demonstrate your knowledge on this topic.   

**1. Using Terminal, there are essential commands to know.**

List the correct Terminal commands to do the actions listed below. Replace **CMD** with the correct command sequence. You can keep or enhance the brief description. 

**The last bullet provides an example**.

* [ Ctrl+L ]: Clear the Screen 
* [ pwd ]: Print the "Working Directory"
* [ ls -a ]: List files and folders
* [ defaults write com.apple.finder AppleShowAllFiles TRUE ]: List files and folders, including invisible files
* [ ls -lh ]: List all files and folders, in human readable form
* [ cd <folderName> ]: Change directory
* [ cd / ]: Change directory, go to root directory
* [ cd ~ ]: Change directory and go to user home directory
* [ cd ../ ]: Change directory, go up one folder level
* [ cd ../ ../ ]: Change directory, go up two folder levels
* **cd Desktop/**: Change directory to my desktop! 


**2. Using Terminal...**

**Folder Drop:** Describe what happens when you drag a folder into Terminal. If you type "cd " before dragging the folder into Terminal and press return after dragging a folder to Terminal, could that help you quickly navigate to the folder location? Test this out and describe your results below. 

[ The first action that occurs once i transfer the folder, it comes with an error message. The message states that permission is denied. The next line i used 'cd' before the transfer, once i pressed return the file was accessable. From my understanding you can't access a directory without a pointer. ]


## Topic: Version Control & Git
Version control, also known as revision control, records changes to a file or set of files over time so that you can recall specific versions later. In this class, we are learning Git. Update the information below where indicated.  

**1. There are three types of version control.**

[ 1. Local Version Control System ]
[ 2. Centralized Version Control System ]
[ 3. Distributed Version Control System ]


**2. Using Terminal, there are also essential Git commands to know.**

List the correct Git commands to do the actions listed below in Terminal. Replace CMD with the correct command and keep or enhance the brief description. **The last bullet provides an example**. 

* [ git init ]: Clone a repository
* [ git config - -global user.name "[firstname lastname]"  ]: Set-up a global user name
* [ git config - -global user.email "[vaild-email]"  ]: Set-up a global email address (to match my GitHub account eMail)
* git status : [ Show modified files in working directory, staged for your next commit. ]
* [ git add [file]  ]: Add modified files to the next commit
* [ git commit -m "{New message}" ]: Make a commit with a new message
* [ git log ]: Show my commit history
* **man [command]**: This command will bring up Git's help screen in Terminal!
    



**3. Connecting to GitHub using Terminal.**
HTTPS is the the correct way to connect to GitHub in this course. Describe how you connect to GitHub from Terminal using this protocol. What steps do you take? 

$ git init -b main
$ git add
$ git commit -m
$ git remote(Git URL)
$ git push -u origin main



**4. Using .gitignore and Why it's Important**  
Most repositories contain a .gitignore file. 

* What is the purpose of this file?  
* What is the "**.DS_Store**" file and why would you want to ignore it?
* What other file or folder would you want to add to a .gitignore file and why? 


[ 1. The purpose of .gitignore files are to ensure that certain files not tracked by Git remain untracked. ]
[ 2. .DS_Store an invisible file on the macOS that get automatically created anytime you look into a folder with 'Finder'. You should ignore this file because, it stores custom attributes/metadata of it's containing folder and the names of other files around.]
[ 3. The local folder would be useful because, the # macOS Files has similar files and has the power to purge your 'Finder']

<br>

# Reference Links
Replace the example references below with your own links and recommended resources. It is acceptable to provide multiple links for a single topic and to use material provided to you in this class. You are encouraged to link to your own independent research as well. 

[ Research Summary: What resource(s) did you find most helpful this past week and why? The resource that was the most useful were Eduonix, which explain the three types of version control. This was a useful resource becasue, not only did it explain each version but, where each source is connected. ]

**Terminal Commands**  
[MUO](https://www.makeuseof.com/tag/mac-terminal-commands-cheat-sheet/)  

**Three Types of Version Control**  
[Eduonix](https://blog.eduonix.com/software-development/learn-three-types-version-control-systems/)

**Git Commands**  
[BeanStalk Guides](http://guides.beanstalkapp.com/version-control/common-git-commands.html)

**Connecting to GitHub using Terminal**  
[Homebrew](https://brew.sh)

**Using .gitignore and Why it's Important**  
[BuildThis](https://buildthis.com/ds_store-files-and-why-you-should-know-about-them/)




