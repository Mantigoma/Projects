// Copyright 2007 Castle Project - http://www.castleproject.org/
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

package castle.flexbridge.common
{
	/**
	 * Error thrown by an method to indicate that it
	 * has not been implemented yet.
	 */
	public class NotImplementedError extends Error
	{
		/**
		 * Constructs an not implemented error for the specified method.
		 * @param methodName The name of the method.
		 */
		public function NotImplementedError(methodName : String)
		{
			super("Method '" + methodName + "' has not been implemented.");
		}
	}
}