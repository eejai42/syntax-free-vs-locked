for ($i = 1; $i -le 5; $i++) {
    python ./add-data.py add-root 1 1026 
    python ./add-data.py add-generation 1 1030 1026
    python ./add-data.py add-generation 1 1031 1030
    python ./add-data.py add-generation 1 1032 1031
    python ./add-data.py add-generation 1 1033 1032
    python ./add-data.py add-generation 1 1035 1033

    python ./add-data.py add-root 1 1020 
    python ./add-data.py add-generation 1 1021 1020
    python ./add-data.py add-generation 1 1022 1021
    python ./add-data.py add-generation 1 1027 1022
    python ./add-data.py add-generation 1 1038 1027
    python ./add-data.py add-generation 1 1039 1038
}
