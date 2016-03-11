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
