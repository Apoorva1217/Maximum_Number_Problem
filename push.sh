read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add . Given 3 Integers find the maximum number"
git push origin $a
git checkout master
git merge $a
git push origin master --force
