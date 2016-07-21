using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDirectory : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDirectory";

		public new static readonly string MRClassNameKey;

		static vtkDirectory()
		{
			vtkDirectory.MRClassNameKey = "class vtkDirectory";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDirectory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDirectory"));
		}

		public vtkDirectory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDirectory New()
		{
			vtkDirectory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectory.vtkDirectory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDirectory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDirectory.vtkDirectory_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDirectory_DeleteDirectory_01(string dir);

		public static int DeleteDirectory(string dir)
		{
			return vtkDirectory.vtkDirectory_DeleteDirectory_01(dir);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDirectory_FileIsDirectory_02(HandleRef pThis, string name);

		public int FileIsDirectory(string name)
		{
			return vtkDirectory.vtkDirectory_FileIsDirectory_02(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectory_GetCurrentWorkingDirectory_03(string buf, uint len);

		public static string GetCurrentWorkingDirectory(string buf, uint len)
		{
			return Marshal.PtrToStringAnsi(vtkDirectory.vtkDirectory_GetCurrentWorkingDirectory_03(buf, len));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectory_GetFile_04(HandleRef pThis, long index);

		public string GetFile(long index)
		{
			return Marshal.PtrToStringAnsi(vtkDirectory.vtkDirectory_GetFile_04(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectory_GetFiles_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetFiles()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectory.vtkDirectory_GetFiles_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkDirectory_GetNumberOfFiles_06(HandleRef pThis);

		public long GetNumberOfFiles()
		{
			return vtkDirectory.vtkDirectory_GetNumberOfFiles_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDirectory_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDirectory.vtkDirectory_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDirectory_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDirectory.vtkDirectory_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDirectory_MakeDirectory_09(string dir);

		public static int MakeDirectory(string dir)
		{
			return vtkDirectory.vtkDirectory_MakeDirectory_09(dir);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectory_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDirectory NewInstance()
		{
			vtkDirectory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectory.vtkDirectory_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDirectory_Open_12(HandleRef pThis, string dir);

		public int Open(string dir)
		{
			return vtkDirectory.vtkDirectory_Open_12(base.GetCppThis(), dir);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDirectory_Rename_13(string oldname, string newname);

		public static int Rename(string oldname, string newname)
		{
			return vtkDirectory.vtkDirectory_Rename_13(oldname, newname);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectory_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDirectory SafeDownCast(vtkObjectBase o)
		{
			vtkDirectory vtkDirectory = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectory.vtkDirectory_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectory = (vtkDirectory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectory.Register(null);
				}
			}
			return vtkDirectory;
		}
	}
}
