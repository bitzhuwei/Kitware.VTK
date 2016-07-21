using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDensifyPolyData : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDensifyPolyData";

		public new static readonly string MRClassNameKey;

		static vtkDensifyPolyData()
		{
			vtkDensifyPolyData.MRClassNameKey = "class vtkDensifyPolyData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDensifyPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDensifyPolyData"));
		}

		public vtkDensifyPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDensifyPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDensifyPolyData New()
		{
			vtkDensifyPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDensifyPolyData.vtkDensifyPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDensifyPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDensifyPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDensifyPolyData.vtkDensifyPolyData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkDensifyPolyData_GetNumberOfSubdivisions_01(HandleRef pThis);

		public virtual uint GetNumberOfSubdivisions()
		{
			return vtkDensifyPolyData.vtkDensifyPolyData_GetNumberOfSubdivisions_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDensifyPolyData_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDensifyPolyData.vtkDensifyPolyData_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDensifyPolyData_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDensifyPolyData.vtkDensifyPolyData_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDensifyPolyData_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDensifyPolyData NewInstance()
		{
			vtkDensifyPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDensifyPolyData.vtkDensifyPolyData_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDensifyPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDensifyPolyData_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDensifyPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkDensifyPolyData vtkDensifyPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDensifyPolyData.vtkDensifyPolyData_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDensifyPolyData = (vtkDensifyPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDensifyPolyData.Register(null);
				}
			}
			return vtkDensifyPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDensifyPolyData_SetNumberOfSubdivisions_07(HandleRef pThis, uint _arg);

		public virtual void SetNumberOfSubdivisions(uint _arg)
		{
			vtkDensifyPolyData.vtkDensifyPolyData_SetNumberOfSubdivisions_07(base.GetCppThis(), _arg);
		}
	}
}
