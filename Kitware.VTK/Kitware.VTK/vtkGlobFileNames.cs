using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGlobFileNames : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGlobFileNames";

		public new static readonly string MRClassNameKey;

		static vtkGlobFileNames()
		{
			vtkGlobFileNames.MRClassNameKey = "class vtkGlobFileNames";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGlobFileNames.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlobFileNames"));
		}

		public vtkGlobFileNames(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGlobFileNames_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGlobFileNames New()
		{
			vtkGlobFileNames result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlobFileNames.vtkGlobFileNames_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlobFileNames)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGlobFileNames() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGlobFileNames.vtkGlobFileNames_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGlobFileNames_AddFileNames_01(HandleRef pThis, string pattern);

		public int AddFileNames(string pattern)
		{
			return vtkGlobFileNames.vtkGlobFileNames_AddFileNames_01(base.GetCppThis(), pattern);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGlobFileNames_GetDirectory_02(HandleRef pThis);

		public virtual string GetDirectory()
		{
			return Marshal.PtrToStringAnsi(vtkGlobFileNames.vtkGlobFileNames_GetDirectory_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGlobFileNames_GetFileNames_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetFileNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlobFileNames.vtkGlobFileNames_GetFileNames_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGlobFileNames_GetNthFileName_04(HandleRef pThis, int index);

		public string GetNthFileName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkGlobFileNames.vtkGlobFileNames_GetNthFileName_04(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGlobFileNames_GetNumberOfFileNames_05(HandleRef pThis);

		public int GetNumberOfFileNames()
		{
			return vtkGlobFileNames.vtkGlobFileNames_GetNumberOfFileNames_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGlobFileNames_GetRecurse_06(HandleRef pThis);

		public virtual int GetRecurse()
		{
			return vtkGlobFileNames.vtkGlobFileNames_GetRecurse_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGlobFileNames_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGlobFileNames.vtkGlobFileNames_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGlobFileNames_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGlobFileNames.vtkGlobFileNames_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGlobFileNames_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGlobFileNames NewInstance()
		{
			vtkGlobFileNames result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlobFileNames.vtkGlobFileNames_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlobFileNames)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGlobFileNames_RecurseOff_11(HandleRef pThis);

		public virtual void RecurseOff()
		{
			vtkGlobFileNames.vtkGlobFileNames_RecurseOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGlobFileNames_RecurseOn_12(HandleRef pThis);

		public virtual void RecurseOn()
		{
			vtkGlobFileNames.vtkGlobFileNames_RecurseOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGlobFileNames_Reset_13(HandleRef pThis);

		public void Reset()
		{
			vtkGlobFileNames.vtkGlobFileNames_Reset_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGlobFileNames_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGlobFileNames SafeDownCast(vtkObjectBase o)
		{
			vtkGlobFileNames vtkGlobFileNames = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlobFileNames.vtkGlobFileNames_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGlobFileNames = (vtkGlobFileNames)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGlobFileNames.Register(null);
				}
			}
			return vtkGlobFileNames;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGlobFileNames_SetDirectory_15(HandleRef pThis, string _arg);

		public virtual void SetDirectory(string _arg)
		{
			vtkGlobFileNames.vtkGlobFileNames_SetDirectory_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGlobFileNames_SetRecurse_16(HandleRef pThis, int _arg);

		public virtual void SetRecurse(int _arg)
		{
			vtkGlobFileNames.vtkGlobFileNames_SetRecurse_16(base.GetCppThis(), _arg);
		}
	}
}
