read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add . Extend the max method to take more then three parameters"
git push origin $a
git checkout master
git merge $a
git push origin master --force
