using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTimePointToString : vtkDataObjectAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTimePointToString";

		public new static readonly string MRClassNameKey;

		static vtkTimePointToString()
		{
			vtkTimePointToString.MRClassNameKey = "class vtkTimePointToString";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTimePointToString.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTimePointToString"));
		}

		public vtkTimePointToString(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTimePointToString_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTimePointToString New()
		{
			vtkTimePointToString result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTimePointToString.vtkTimePointToString_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimePointToString)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTimePointToString() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTimePointToString.vtkTimePointToString_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTimePointToString_GetISO8601Format_01(HandleRef pThis);

		public virtual int GetISO8601Format()
		{
			return vtkTimePointToString.vtkTimePointToString_GetISO8601Format_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTimePointToString_GetOutputArrayName_02(HandleRef pThis);

		public virtual string GetOutputArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkTimePointToString.vtkTimePointToString_GetOutputArrayName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTimePointToString_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTimePointToString.vtkTimePointToString_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTimePointToString_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTimePointToString.vtkTimePointToString_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTimePointToString_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTimePointToString NewInstance()
		{
			vtkTimePointToString result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTimePointToString.vtkTimePointToString_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimePointToString)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTimePointToString_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTimePointToString SafeDownCast(vtkObjectBase o)
		{
			vtkTimePointToString vtkTimePointToString = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTimePointToString.vtkTimePointToString_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTimePointToString = (vtkTimePointToString)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTimePointToString.Register(null);
				}
			}
			return vtkTimePointToString;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTimePointToString_SetISO8601Format_08(HandleRef pThis, int _arg);

		public virtual void SetISO8601Format(int _arg)
		{
			vtkTimePointToString.vtkTimePointToString_SetISO8601Format_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTimePointToString_SetOutputArrayName_09(HandleRef pThis, string _arg);

		public virtual void SetOutputArrayName(string _arg)
		{
			vtkTimePointToString.vtkTimePointToString_SetOutputArrayName_09(base.GetCppThis(), _arg);
		}
	}
}
