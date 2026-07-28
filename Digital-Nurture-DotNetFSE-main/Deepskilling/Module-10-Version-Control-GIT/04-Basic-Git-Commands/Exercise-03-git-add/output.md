# Exercise 03 – git add

## Command Executed

```bash
echo Hello > file.txt
git add .
git status
```

## Output

```text
C:\Users\subbu\GitDemo>echo Hello > file.txt

C:\Users\subbu\GitDemo>git add .

C:\Users\subbu\GitDemo>git status
On branch master

No commits yet

Changes to be committed:
  (use "git rm --cached <file>..." to unstage)

        new file:   file.txt
```

## Observation

The `echo` command created a new file named `file.txt`. The `git add .` command staged the file, and `git status` confirmed that `file.txt` is in the staging area and ready to be committed.

## Result

The file was successfully added to the Git staging area.