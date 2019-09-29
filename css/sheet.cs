* {
    padding: 0;
    margin: 0;
}


/* Basic Typography */
html,
body {
    font-size: 1em;
    line-height: 1.65em;
    font-family: "Open Sans", sans-serif;
    font-weight: 300;
    background: #fff;
    color: #444;
}

html {
    height: 100%;
}

body {
    padding: 2em 2.5em 1em 20em;
}

/* Blocks */
header {
    border-right: 1px #eee solid;
    padding: 1em;
    position: fixed;
    top: 0;
    left: 0;
    height: 100%;
    width: 18.5em;
    background-repeat: no-repeat;
    background-size: cover;
}

#content {
    display: block;
    width: 100%;
}

article {
    border-bottom: 0.1em #eee solid;
    padding-bottom: 1.7em;
    max-width: 56em;
}

p,
hr,
h4,
h5,
h6 {
    margin-top: 0.9em;
    margin-bottom: 0.9em;
}

/* Headings */
h1,
h2,
h3,
h4,
h5,
h6 {
    font-family: "Bree Serif", serif;
    font-weight: 400 !important;
}

h1 {
    font-size: 2.5em;
    line-height: 1.1em;
    margin-top: 0.6em;
    margin-bottom: 0.6em;
}

h2 {
    font-size: 1.9em;
    line-height: 1.2em;
    margin-top: 0.7em;
    margin-bottom: 0.7em;
}

h3 {
    font-size: 1.4em;
    line-height: 1.3em;
    margin-top: 0.8em;
    margin-bottom: 0.8em;
}

h4 {
    font-size: 1.3em;
}

h5 {
    font-size: 1.2em;
}

h6 {
    font-size: 1.1em;
}

/* Page Elements */
img,
iframe {
    max-width: 100%;
}

a {
    font-weight: 700;
    text-decoration: none;
    color: #00cdcd; /* Change Link Color */
}

a:hover {
    text-decoration: underline;
}

h1 a,
h2 a,
h3 a,
h4 a,
h5 a,
h6 a {
    font-weight: 400 !important;
}

strong {
    font-weight: 700;
}

blockquote {
    border-left: 0.4em solid #eee;
    padding-left: 1.2em;
    font-size: 1.3em;
}


ul,
ol {
    margin-left: 3em;
}

code {
    font-size: 1.4em;
    background: #eee;
}

pre {
    font-size: 0.8em;
    line-height: 2em;
    background: #eee;
    padding: 1em;
    word-break: break-all;
    word-wrap: break-word;
    white-space: pre;
    white-space: -moz-pre-wrap;
    white-space: pre-wrap;
    white-space: pre \9;
}

input {
    font-size: 1em;
    padding: 0.3em;
}

/* Sidebar */
header h1 {
    font-size: 1.9em;
    margin-top: 0.8em;
    margin-bottom: 0.6em;
}

header h1 a {
    color: #444;
}

header h1 a:hover {
    text-decoration: none;
}

header #logo img {
    width: 9em;
    height: 9em;
    border-radius: 4.5em;
    -moz-border-radius: 4.5em;
    -webkit-border-radius: 4.5em;
    border: none;
}

#follow-icons {
    font-size: 0.7em;
    margin-top: -0.7em;
    margin-bottom: 1.5em;
}

#follow-icons a {
    color: #ccc;
    transition: color 500ms;
    -webkit-transition: color 500ms;
    margin-right: 5px;
}

#follow-icons a:hover {
    color: #00cdcd;
    transition: color 500ms;
    -webkit-transition: color 500ms;
}

#follow-icons span {
    vertical-align: top;
    margin-left: -0.15em;
    margin-right: -0.15em;
}

#follow-icons span .fa-stack-1x {
    font-size: 1.05em;
    line-height: 1.9em;
}

header h6 {
    margin-top: 0.5em;
}

/* Posts */
article span.post-stamp {
    color: #888;
}

h1.post-title {
    margin-top: 0.35em;
    margin-bottom: 0.6em;
}

h3.post-title {
    margin-top: 0.4em;
    padding-bottom: 0.9em;
    border-bottom: 1px solid #eee;
    font-size: 1.2em;
    color: #444;
}

.post-title .feature-star {
    font-size: 0.9em;
}

.post p {
    font-family: georgia, serif;
    font-weight: 300;
    letter-spacing: 0.02rem;
    line-height: 1.6em;
    font-size: 1.2rem;
}

.separator,
.taglist,
.feature-star {
    color: #ccc;
}

.taglist a {
    background-color: #ccc;
    color: #fff;
    display: inline-block;
    line-height: 1.5em;
    padding: 0.3em 0.6em 0.3em 0.6em;
    vertical-align: 20%;
    font-size: 0.5em;
    font-family: "Open Sans", sans-serif;
    font-weight: 700 !important;
    text-transform: uppercase;
    letter-spacing: 0.05em;
    border-radius: 0.25em;
    -moz-border-radius: 0.25em;
    -webkit-border-radius: 0.25em;
}

#social-bar {
    margin-top: 1.5em;
    background-color: #eee;
    padding: 0.5em;
}

#comments {
    margin-top: 1em;
    padding-bottom: 0.2em;
    border-bottom: 1px solid #eee;
}

/* Footer */
.pagination {
    margin-bottom: 1em;
}

footer a {
    font-weight: 300;
    color: #888;
    text-decoration: underline;
}

footer a:hover {
    color: #444;
    text-decoration: none;
}

/* Static timeline page */
.timeline-item {
    padding: 2em 2em 2em 0;
    position: relative;
}

.timeline-item h4 {
    margin: 0;
    padding: 1em 0 0 1.5em;
}

.timeline-item p {
    border-left: 2px solid #323758;
    padding-left: 2em;
}

.timeline-item::before {
    content: attr(date-is);
    position: absolute;
    left: 2.5em;
    font-weight: bold;
    top: 1em;
    display: block;
    font-family: "Roboto", sans-serif;
    font-weight: 700;
    font-size: 0.785rem;
    color: #323758;
    text-transform: uppercase;
    letter-spacing: 1px;
}

.timeline-item h4::before {
    width: 10px;
    height: 10px;
    display: block;
    position: absolute;
    left: -11px;
    content: attr(event-icon);
}

/* Large Screens */
@media only screen and (min-width: 1281px) {
    html,
    body {
        font-size: 1.1em;
    }
}

/* Small Screens */
@media only screen and (max-width: 800px) {
    body {
        padding: 0;
    }

    header {
        border-right: none;
        border-bottom: 1px #eee solid;
        position: relative;
        height: auto;
        width: auto;
        text-align: center;
        padding-bottom: 1em;
    }

    #content {
        margin-left: 0;
        padding: 2em 2em 1em 2em;
        width: auto;
    }

    footer {
        padding: 0 2.5em 2em 2.5em;
    }
}

/* Tiny Screens */
@media only screen and (max-width: 320px) {
    header {
        padding: 1.2em 1.2em 0.6em 1.2em;
    }

    #content {
        padding: 1.2em 1.2em 0.6em 1.2em;
    }

    footer {
        padding: 0 1.5em 1.2em 1.5em;
    }

    ul,
    ol {
        margin-left: 2em;
    }
}
