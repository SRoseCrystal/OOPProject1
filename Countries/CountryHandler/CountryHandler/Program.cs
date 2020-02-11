using System;
using System.IO;

namespace CountryHandler
{
    class CountryImport
    {
        int main()
        {
            File* fp;
            char str[MAXCHAR];
            char* filename = "c:\\countries.txt";

            fp = fopen(filename, "r");
            if (fp == NULL)
            {
                printf("Could not open file %s", filename);
                return 1;
            }
            while (fgets(str, MAXCHAR, fp) != NULL)
                printf("%s", str);
            fclose(fp);
            return 0;
        }
    }
}
