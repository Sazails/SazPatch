## SazPatch
Create patches and use them!

### The reason?
I like to create projects and I like the idea of an updater, why download the full project files when you can have the option to install only the needed files for this update?

### How to use?
#### Saz Patch Maker
- The idea of the patch maker is to create a "Patch" that will be placed from where you launch the SazPatchMaker.exe, the "Patch" folder will contain a copy of new/updated files between the old and new content folders.
  
- When launching the patch maker you will have to enter the old content path (outdated folder) and the new content path (updated folder) as this will allow the program to check for any modified/new/missing files and add them to the "Patch" folder.

- The "Patch" folder contains a .log file which needs to be there in order to use the SazPatcher. However, you can also drag the files into the old content folder if you want by yourself.

#### Saz Patcher
- The idea of the patcher is to get files from the "Patch" folder and move them to the current directory of the SazPatcher.exe. 

- Make sure you put the "Patch" folder and "SazPatcher.exe" in the directory you want the files to be moved into. 

#### Example
Lets say you have two folders "Game0.1" and "Game0.2", the 0.2 version has new files and files that have been changed.
1. Run SazPatchMaker.exe on Desktop, for the old content path enter the path to the folder "Game0.1", and for the new content path enter the path to the folder "Game0.2". (The path will look something like this "C:\Game0.1")
2. Once the SazPatchMaker.exe has run on the desktop there will be a Patch file containing the new files and changed files, drag the Patch folder into the "Game0.1" folder.
3. Drag the SazPatcher.exe into the Game0.1 folder, where the Patch folder is.
4. Run the SazPatcher.exe and let it do its of moving the files into the folder.
5. That is it! You have just updated the old folder with the new contents!
