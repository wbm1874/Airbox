# Picture Viewer

This solution has 3 projects: 
- `Airbox`, which contains the views and service implementations.
- `Airbox.Data`, which contains the service interfaces, models and view-models. All the classes in this project should all beunit-testable.
- `Airbox.DataTests`, which is the start of the unit-tests for `Airbox.Data`. `Moq` was used for mocking services.

The view-models utilise the community-toolkit MVVM helper attributes, described at https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/, to generate the `INotifyPropertyChanged` code and easily create commands in the view-model.

---

Note: A bug in MAUI was found regarding the sizing of images inside of a collection-view. A clunky work-around was found for this (see `ImageListView.xaml`, line 26). Even with the workaround, the layout isn't quite right, 
but a more correct fix would involve writing am image-source that resizes the image rather than leaving the resizing to the `Image` control – time prevented this from being implemented.
