function saveAsFile(filename, bytesAsBase64) {
    var link = document.createElement("a");
    link.download = filename;
    link.href = "data:application/octed-stream;base64," + bytesAsBase64;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}