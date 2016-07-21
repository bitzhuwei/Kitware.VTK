using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStringToTimePoint : vtkDataObjectAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStringToTimePoint";

		public new static readonly string MRClassNameKey;

		static vtkStringToTimePoint()
		{
			vtkStringToTimePoint.MRClassNameKey = "class vtkStringToTimePoint";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStringToTimePoint.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStringToTimePoint"));
		}

		public vtkStringToTimePoint(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStringToTimePoint_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStringToTimePoint New()
		{
			vtkStringToTimePoint result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStringToTimePoint.vtkStringToTimePoint_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringToTimePoint)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStringToTimePoint() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStringToTimePoint.vtkStringToTimePoint_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStringToTimePoint_GetOutputArrayName_01(HandleRef pThis);

		public virtual string GetOutputArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkStringToTimePoint.vtkStringToTimePoint_GetOutputArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStringToTimePoint_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStringToTimePoint.vtkStringToTimePoint_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStringToTimePoint_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStringToTimePoint.vtkStringToTimePoint_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStringToTimePoint_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStringToTimePoint NewInstance()
		{
			vtkStringToTimePoint result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStringToTimePoint.vtkStringToTimePoint_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringToTimePoint)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStringToTimePoint_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStringToTimePoint SafeDownCast(vtkObjectBase o)
		{
			vtkStringToTimePoint vtkStringToTimePoint = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStringToTimePoint.vtkStringToTimePoint_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringToTimePoint = (vtkStringToTimePoint)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringToTimePoint.Register(null);
				}
			}
			return vtkStringToTimePoint;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToTimePoint_SetOutputArrayName_07(HandleRef pThis, string _arg);

		public virtual void SetOutputArrayName(string _arg)
		{
			vtkStringToTimePoint.vtkStringToTimePoint_SetOutputArrayName_07(base.GetCppThis(), _arg);
		}
	}
}
