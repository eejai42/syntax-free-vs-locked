# for ($i = 1; $i -le 20; $i++) {
# python ./step-1-add-data.py add-root 1 1190 
# python ./step-1-add-data.py add-root 1 1193 

# python ./step-1-add-data.py add-generation 1 1191 1190
# python ./step-1-add-data.py add-generation 1 1195 1193

# python ./step-1-add-data.py add-generation 1 1204 1191
# python ./step-1-add-data.py add-generation 1 1196 1195

# python ./step-1-add-data.py add-generation 1 1205 1204
# python ./step-1-add-data.py add-generation 1 1197 1196

# python ./step-1-add-data.py add-generation 1 1206 1205
# python ./step-1-add-data.py add-generation 1 1198 1197

#  # phase 2
# }

# python ./step-2-connect-artifacts.py
# python ./step-3-cleanup-data.py


for ($i = 1; $i -le 40; $i++) {
    python ./step-1-add-data.py add-generation 1 1212 1193 phase2

    python ./step-1-add-data.py add-generation 1 1213 1195 phase2

    python ./step-1-add-data.py add-generation 1 1214 1196 phase2

    python ./step-1-add-data.py add-generation 1 1215 1197 phase2

    python ./step-1-add-data.py add-generation 1 1216 1198 phase2

}

python ./step-2-connect-artifacts.py
python ./step-3-cleanup-data.py

