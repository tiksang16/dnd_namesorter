# dnd_namesorter

## How to Run
1. Clone this repository to your local machine.
    ```shell
    git clone https://github.com/tiksang16/dnd_namesorter.git
    cd dnd_namesorter
    ```

2. Navigate to the `NameSorter` directory.
    ```shell
    cd NameSorter
    ```

3. Run the application with the provided unsorted names file.
    ```shell
    dotnet run ./unsorted-names-list.txt
    ```

    Alternatively, you can publish the application to get a self-contained executable:
    ```shell
    dotnet publish -c Release -r win-x64 --self-contained
    ```

    And then run the generated executable file with the unsorted names file as an argument:
    ```shell
    ./bin/Release/net7.0/win-x64/publish/NameSorter ./unsorted-names-list.txt
    ```

## How to Test
1. Navigate to the root directory of the project and run the tests using the `dotnet test` command.
    ```shell
    dotnet test
    ```


