// Copyright 2022 dSPACE GmbH, Mark Lechtermann, Matthias Nissen and Contributors
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Runtime.InteropServices;
namespace dSPACE.Runtime.InteropServices.Test;

[ComVisible(false)]
public interface ITestInterfaceComInvisible
{
    void DoSomething(ITestInterfaceComInvisible param);
}

[ComVisible(true)]
public interface ITestInterfaceComVisible
{
    void DoSomething(ITestInterfaceComInvisible param);
}

[ComVisible(true)]
public interface ITestInterfaceIndexerInvisible
{
    public string this[int x] { get; }

    [ComVisible(false)]
    public string this[string s] { get; }
}
