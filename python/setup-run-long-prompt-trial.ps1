for ($i = 1; $i -le 25; $i++) {
    python ./step-1-add-data.py add-root 1 1042 
    python ./step-1-add-data.py add-generation 1 1043 1042
    python ./step-1-add-data.py add-generation 1 1044 1043
    python ./step-1-add-data.py add-generation 1 1045 1044
    python ./step-1-add-data.py add-generation 1 1046 1045
    python ./step-1-add-data.py add-generation 1 1110 1046
    python ./step-1-add-data.py add-generation 1 1111 1110
    python ./step-1-add-data.py add-generation 1 1112 1111
    python ./step-1-add-data.py add-generation 1 1113 1112
    python ./step-1-add-data.py add-generation 1 1114 1113

    python ./step-1-add-data.py add-root 1 1047 
    python ./step-1-add-data.py add-generation 1 1048 1047
    python ./step-1-add-data.py add-generation 1 1049 1048
    python ./step-1-add-data.py add-generation 1 1050 1049
    python ./step-1-add-data.py add-generation 1 1051 1050
    python ./step-1-add-data.py add-generation 1 1115 1051
    python ./step-1-add-data.py add-generation 1 1116 1115
    python ./step-1-add-data.py add-generation 1 1117 1116
    python ./step-1-add-data.py add-generation 1 1118 1117
    python ./step-1-add-data.py add-generation 1 1119 1118
}


python ./step-2- connect-artifacts.py
python ./step-3-cleanup-data.py
