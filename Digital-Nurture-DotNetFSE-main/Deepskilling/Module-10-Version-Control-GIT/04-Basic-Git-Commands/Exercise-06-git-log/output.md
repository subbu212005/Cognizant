# Exercise 06 – git log

## Command Executed

```bash
git log

git log --oneline

git log --graph
```

## Output

```text
C:\Users\subbu\GitDemo>git log
commit 6731c681daa8b1b0067e5db8a4f10507ca460e8b (HEAD -> master)
Author: Subrahmanyeswara <yedula2005@gmail.com>
Date:   Tue Jul 28 09:04:51 2026 +0530

    Initial commit

C:\Users\subbu\GitDemo>git log --oneline
6731c68 (HEAD -> master) Initial commit

C:\Users\subbu\GitDemo>git log --graph
* commit 6731c681daa8b1b0067e5db8a4f10507ca460e8b (HEAD -> master)
  Author: Subrahmanyeswara <yedula2005@gmail.com>
  Date:   Tue Jul 28 09:04:51 2026 +0530

      Initial commit
```

## Observation

The `git log` command successfully displayed the complete commit history of the repository. It showed the full commit hash, author name, email address, commit date, and commit message. The `git log --oneline` command displayed a compact version of the history, while `git log --graph` displayed the commit history in a graphical format.

## Result

The commit history was successfully viewed using the `git log`, `git log --oneline`, and `git log --graph` commands.