# Wordpress Boilerplate using composer, bedrock & sage
This boilerplate uses composer, bedrock.

## Features

- Bedrock
- Configured composer.json under /bedrock folder

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development.

### # Requirements
- PHP version >= 8.0

### # Installation using Lando
```
NOTE: before running the installation, please make sure to follow the requirements above.
```

1. Go to `/Development` folder. Create `websites` folder.
2. Git clone the `sage-boiler`under `/Development/websites`.
3. Go to `/sage-boiler/` folder.
4. Edit `lando.yml` then change all the name `sage-boiler` to your preferred name or base on your root directory. Note the all the name must be same.
5. Run `lando composer install` in the `/sage-boiler/` folder under the root directory.
6. Run `lando composer update` in the `/sage-boiler/` folder under the root directory.
7. Run `lando start`
8. Copy the `.env.lando.example` and rename it to `.env`. Edit `.env`.
9. Run `lando info` to get the credentials for `DB_NAME`, `DB_USER`, `DB_PASSWORD`, `DB_HOST`.
10. Set your `DB_NAME`, `DB_USER`, `DB_PASSWORD`. In `DB_HOST`, leave it as `database` value.
11. In `line 14`. Change WP_HOME='http://example.com' to `http://sage-boiler.lndo.site` or what APPSERVER provided by lando after running the `lando start`.
12. In `.env`. Generate your keys here: https://roots.io/salts.html and put it in the line 19-26.
13. To run `wp-cli`, you can use `lando wp`.
14. To run `yarn` in `sage-theme`, you can use either `lando yarn start` or `yarn start`
13. Remove `.git` under `/sage-boiler/` folder.
14. Last is run `lando rebuild -y` in your terminal.

### # Installation using XAMPP
```
NOTE: before running the installation, please make sure to follow the requirements above.
```

1. Go to `/Documents` folder. Create `websites` folder.
2. Git clone the `sage-boiler`under `/Documents/websites`.
3. Create database in phpmyadmin.
4. Go to `/sage-boiler/` folder.
5. Copy the `.env.example` and rename it to `.env`. Edit `.env`.
6. Set your `DB_NAME`, `DB_USER`, `DB_PASSWORD`. In `DB_HOST`, leave it as `localhost` value.
7. In `line 14`. Change WP_HOME='http://example.com' to `http://sage-boiler.local` or your prefer localhost site name.
8. In `.env`. Generate your keys here: https://roots.io/salts.html and put it in the line 19-26.
9. Run `composer install` in the `/sage-boiler/` folder under the root directory.
10. Run `composer update` in the `/sage-boiler/` folder under the root directory.
11. Remove `.git` under `/sage-boiler/` folder.
12. Setup virtual host on xampp:
##### For Linux User: <br />
- Go to `~/opt/lampp/etc` folder.
- Edit `httpd.conf` file. Uncomment this line `Include etc/extra/httpd-vhosts.conf`
- Go to `~/opt/lampp/etc/extra` folder.
- Edit `httpd-vhosts.conf` file.
- Paste this code at the bottom:
~~~
<VirtualHost *:80>
    DocumentRoot "/home/jayson/Documents/websites/sage-boiler/web"
    ServerName sage-boiler.local
    <Directory "/home/jayson/Documents/websites/sage-boiler/web">
        Options Indexes FollowSymLinks ExecCGI
        AllowOverride All
        Require all granted
        Header Set Access-Control-Allow-Origin "*"
    </Directory>
    ErrorLog "logs/sage-boiler.local_error_log"
</VirtualHost>
~~~
- Change the `ServerName` value to your `.env WP_HOME=` value `http://sage-boiler.local`.
- Go to `~/etc`. Search and find `hosts` file under `~/etc` folder.
- Edit `hosts` file.
- Add this line of code `127.0.0.1 wp-boiler.local` at the top of after the `127.0.0.1	localhost`.
- You can change the `sage-boiler.local` value. Make sure the value is same as `VirtualHost ServerName` value.
- Run this in terminal. `sudo /opt/lampp/lampp restart`.

##### For Mac User: <br />
- Go to `/application/xampp/xamppfiles/etc` folder.
- Edit `httpd.conf` file. Uncomment this line `Include etc/extra/httpd-vhosts.conf`
- Go to `/application/xampp/xamppfiles/etc/extra` folder.
- Edit `httpd-vhosts.conf` file.
- Paste this code at the bottom:
~~~
<VirtualHost *:80>
    DocumentRoot "/Users/username/Documents/websites/sage-boiler/web"
    ServerName sage-boiler.local
    <Directory "/Users/username/Documents/websites/sage-boiler/web">
        Options Indexes FollowSymLinks ExecCGI
        AllowOverride All
        Require all granted
        Header Set Access-Control-Allow-Origin "*"
    </Directory>
    ErrorLog "logs/sage-boiler.local_error_log"
</VirtualHost>
~~~
- Change the `ServerName` value to your `.env WP_HOME=` value `http://sage-boiler.local`.
- Open terminal and type this command `sudo nano /etc/hosts`.
- Add this line of code `127.0.0.1 sage-boiler.local` at the top after the `127.0.0.1	localhost`.
- You can change the `sage-boiler.local` value. Make sure the value is same as `VirtualHost ServerName` value.
- Run this in terminal. `sudo /applications/xampp/xamppfiles/xampp restart`.


### # Theme workflow settings/installation
1. Read the file `README.md` under `/yournewsite/web/app/themes/wp-boiler-theme`.

### # Add plugins with Composer
- $ composer require wpackagist-plugin/advanced-custom-fields

### # Enable X-XSS-Protection
1. Make sure the `HTTP Headers` plugin was activated
2. Go to http headers under settings
3. Edit `X-XSS-Protection`. Turn on. Select `1;mode=block` in the select field.

### # Enable Strict-Transport-Security
1. Make sure the `HTTP Headers` plugin was activated
2. Go to http headers under settings
3. Edit `Strict-Transport-Security`. Turn on. Set max-age: 1 year

### # Enable Content-Security-Policy
1. Make sure the `HTTP Headers` plugin was activated
2. Go to http headers under settings
3. Edit `Content-Security-Policy`. Turn on.
4. In `script-src`. Check `self, unsafe-inline, unsafe-eval, https` only.
5. In `style-src`. Check `self, unsafe-inline, https` only.

### # Enable X-Content-Type-Options
1. Make sure the `HTTP Headers` plugin was activated
2. Go to http headers under settings
3. Edit `X-Content-Type-Options`. Turn on.
4. Select `nosniff`.

### # Enable X-Frame-Options
1. Make sure the `HTTP Headers` plugin was activated
2. Go to http headers under settings
3. Edit `X-Frame-Options`. Turn on.
4. Select `SAMEORIGIN`.

### # Referrer-Policy
1. Make sure the `HTTP Headers` plugin was activated
2. Go to http headers under settings
3. Edit `Referrer-Policy`. Turn on.
4. Select `no-referrer-when-downgrade`.

### # Using wp-cli on XAMPP
1. Install wp-cli: https://wp-cli.org/

##### For Linux User: <br />
- Open terminal and type: `sudo nano ~/.bashrc`.
- Add this command line:
```
XAMPP_PATH=/opt/lampp/bin:/opt/lampp/sbin
export PATH="$XAMPP_PATH:$PATH"
```
- Refresh bash profile using this command `source ~/.bashrc`.
##### For Mac User: <br />
- Open terminal and type: `sudo nano ~/.bash_profile`.
- Add this command line:
~~~
export XAMPP_PATH=/Applications/XAMPP/xamppfiles/bin:/Applications/XAMPP/xamppfiles/sbin
export PATH="$XAMPP_PATH:$PATH"
~~~
- Refresh bash profile using this command `source ~/.bash_profile`.

### # Publishing localsite using tunnel server. (Ex. ngrok)
- Use this guide only if you want to publish your devsite into tunnel server like ngrok.
1. Enable plugin `url-path-auto`. (Note: url-path-auto will change your http://example.com/sample-post to /sample-post. So basically it will remove the localsite url. See the https://github.com/hallowichig0/url-path-auto for more info)

### # ACF Pro composer token
4b6227c3f888a611099b8a438ab2576c0a6a0244

### # Yoast SEO Setup
- After installed and setup Yoast SEO. Remove `bloginfo('name');` in the <title> tag of header.php

### # Robot Setup
- Edit robots.txt under `root/web` folder. Change the `site url` in the `Sitemap: https://yoursite.com/sitemap_index.xml`. 
  
### # Production
- use `wp acorn optimize` to create cache file in bootstrap directory
- use `yarn build` to generates all of your build artifacts but applies optimizations to them (i.e. minify CSS & JS, cache CSS & JS, uglify JS, purge appropriate CSS selectors, etc) and defines the “production” environment in Node, which some packages will look for an apply optimizations for.
