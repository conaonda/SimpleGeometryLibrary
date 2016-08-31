clc;
close all;
clear all;
fp = fopen('xyz.csv');
ret = textscan(fp, '%s %f %f %f', 'delimiter', ',');
names = ret{1};
xs = ret{2};
ys = ret{3};
zs = ret{4};
fclose(fp);
xyz = [xs ys zs];
color = rand(size(xyz));
scatter3(xs, ys, zs, [], color, 'linewidth', 2);
for i = 1:size(xs)
    t = text(xs(i), ys(i), zs(i)+100, names{i}, 'color', color(i,:));
end

standardIndex = 13;
tmp = ones(size(xs),1);
dst = [tmp*xyz(standardIndex,1) tmp*xyz(standardIndex,2) tmp*xyz(standardIndex,3)];
distances = sqrt(sum((xyz-dst).^2,2));
distances

manual = sqrt((xyz(1,1)-xyz(standardIndex,1))^2 + (xyz(1,3)-xyz(standardIndex,3))^2 + (xyz(1,2)-xyz(standardIndex,2))^2);
distances(1)
manual