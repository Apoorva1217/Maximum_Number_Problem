read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Refactor . Refactored all the 3 to One Generic Method and find the maximum"
git push origin $a
git checkout master
git merge $a
git push origin master --force

