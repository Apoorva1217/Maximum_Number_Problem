read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add . Extend the max method to also print the max to std out using Generic Method"
git push origin $a
git checkout master
git merge $a
git push origin master --force
