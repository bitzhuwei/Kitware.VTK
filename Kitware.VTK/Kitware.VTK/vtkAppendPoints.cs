using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAppendPoints : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAppendPoints";

		public new static readonly string MRClassNameKey;

		static vtkAppendPoints()
		{
			vtkAppendPoints.MRClassNameKey = "class vtkAppendPoints";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAppendPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendPoints"));
		}

		public vtkAppendPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAppendPoints New()
		{
			vtkAppendPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendPoints.vtkAppendPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAppendPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAppendPoints.vtkAppendPoints_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendPoints_GetInputIdArrayName_01(HandleRef pThis);

		public virtual string GetInputIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkAppendPoints.vtkAppendPoints_GetInputIdArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAppendPoints_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAppendPoints.vtkAppendPoints_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAppendPoints_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAppendPoints.vtkAppendPoints_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendPoints_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAppendPoints NewInstance()
		{
			vtkAppendPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendPoints.vtkAppendPoints_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendPoints_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAppendPoints SafeDownCast(vtkObjectBase o)
		{
			vtkAppendPoints vtkAppendPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendPoints.vtkAppendPoints_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAppendPoints = (vtkAppendPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAppendPoints.Register(null);
				}
			}
			return vtkAppendPoints;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAppendPoints_SetInputIdArrayName_07(HandleRef pThis, string _arg);

		public virtual void SetInputIdArrayName(string _arg)
		{
			vtkAppendPoints.vtkAppendPoints_SetInputIdArrayName_07(base.GetCppThis(), _arg);
		}
	}
}
