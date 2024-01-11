# Picture Viewer

This solution has 3 projects: 
- `Airbox`, which contains the views and service implementations.
- `Airbox.Data`, which contains the service interfaces, models and view-models. All the classes in this project should all beunit-testable.
- `Airbox.DataTests`, which is the start of the unit-tests for `Airbox.Data`. `Moq` was used for mocking services.

The view-models utilise the community-toolkit MVVM helper attributes, described at https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/, to generate the `INotifyPropertyChanged` code and easily create commands in the view-model.

The app has only been tested with Android, but should work with iOS and UWP although time has prevented me from testing this (my Mac doesn't want to talk to my dev PC for some reason...) The app should respond to dark/light system theming and has 
been localised with English and German translations (I know enough German to be able to work an Android phone set to this language. Other languages would require skills I don't have.)

---

Note: A bug in MAUI was found regarding the sizing of images inside of a collection-view. A clunky work-around was found for this (see `ImageListView.xaml`, line 26). Even with the workaround, the layout isn't quite right, 
but a more correct fix would involve writing am image-source that resizes the image rather than leaving the resizing to the `Image` control – time prevented this from being implemented.
