try{
//post
string x;
Asciiencoding enc=new Asciiencoding();
string pass_data="password"+x;
//load it to a byte array
byte[] data=encoding.GetBytes(ass_data);
Webrequest req=Webrequest.Create("request url");
req.Method="POST";
//used header endoding
// for binary data multipart/form-data
req.ContentType="application/x-www-form-urlencoded";
req.ContentLength = data.length;

//request as a file stream now
Stream x=req.GetRequestStream();
x.write(data,0,data.length);
x.close();

// get web responce GET
webresponse response = request.getresponse();
x=response.GetResponceStream();
//read from that stream
StreamReader sr=new StreamReader(x);
//OUTPUT
console.write(sr.ReadtoEnd());
sr.close():
x.close();
}
catch(Exception e){




}
