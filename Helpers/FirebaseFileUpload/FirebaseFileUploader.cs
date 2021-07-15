using System;
using System.IO;
using System.Threading.Tasks;
using Firebase.Auth;
using Firebase.Storage;

namespace PulseXLibraries.Helpers.FirebaseFileUpload
{
    public class FirebaseFileUploadHelper
    {
        public static async Task<FirebaseStorageTask> UploadFileToFirebase(string fileName,MemoryStream fileMemoryStream, string apiKey, string firebaseStorageUrl, string email, string password)
        {
            FirebaseStorageTask firebaseStorageTask;
            // await using var ms = new MemoryStream();
            // await file.CopyToAsync(ms);
            // var fileBytes = ms.ToArray();
            // var stream = new MemoryStream(fileBytes);
            var auth = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
            var a = await auth.SignInWithEmailAndPasswordAsync(email, password);
            var task = new FirebaseStorage(
                    firebaseStorageUrl,
                    new FirebaseStorageOptions
                    {
                        AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                        ThrowOnCancel = true,
                    })
                .Child(fileName)
                .PutAsync(fileMemoryStream);

            task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");
            firebaseStorageTask = task;
            return firebaseStorageTask;
        }
    }
}