# SimpleCSharpApi

This is a basic api that takes in a JSON request, filters the data based on some requirements and returns a JSON response.


## How to use
Go to root path of your where SimpleCSharpApi is hosted e.g myservice.somedomain.com/ 

Post a JSON request like below to the root address.
```json
{  
   "payload":[  
      {  
         "country":"UK",
         "description":"What's life like when you have enough children to field your own football team?",
         "drm":true,
         "episodeCount":3,
         "genre":"Reality",
         "image":{  
            "showImage":"http://mybeautifulcatchupservice.com/img/shows/16KidsandCounting1280.jpg"
         },
         "language":"English",
         "nextEpisode":null,
         "primaryColour":"#ff7800",
         "seasons":[  
            {  
               "slug":"show/16kidsandcounting/season/1"
            }
         ],
         "slug":"show/16kidsandcounting",
         "title":"16 Kids and Counting",
         "tvChannel":"GEM"
      },
      {  
         "slug":"show/seapatrol",
         "title":"Sea Patrol",
         "tvChannel":"Channel 9"
      }
   ]
}
```
Expected filtered response:
```json
{  
   "response":[  
      {  
         "image":"http://mybeautifulcatchupservice.com/img/shows/16KidsandCounting1280.jpg",
         "slug":"show/16kidsandcounting",
         "title":"16 Kids and Counting"
      }
   ]
}
```

## How to Test
To test this you need to open the SimpleCSharpApi.Tests project and in Visual Studio go to Test > Windows > Test Explorer and then Run All Tests. If the tests are not showing please install NUnit 3 Test Adapter in the Extensions and Updates of Visual Studio.
