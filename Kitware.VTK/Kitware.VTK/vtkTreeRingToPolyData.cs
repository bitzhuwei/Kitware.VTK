using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTreeRingToPolyData : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeRingToPolyData";

		public new static readonly string MRClassNameKey;

		static vtkTreeRingToPolyData()
		{
			vtkTreeRingToPolyData.MRClassNameKey = "class vtkTreeRingToPolyData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeRingToPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeRingToPolyData"));
		}

		public vtkTreeRingToPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeRingToPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeRingToPolyData New()
		{
			vtkTreeRingToPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeRingToPolyData.vtkTreeRingToPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeRingToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTreeRingToPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTreeRingToPolyData.vtkTreeRingToPolyData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeRingToPolyData_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkTreeRingToPolyData.vtkTreeRingToPolyData_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeRingToPolyData_GetShrinkPercentage_02(HandleRef pThis);

		public virtual double GetShrinkPercentage()
		{
			return vtkTreeRingToPolyData.vtkTreeRingToPolyData_GetShrinkPercentage_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeRingToPolyData_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTreeRingToPolyData.vtkTreeRingToPolyData_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeRingToPolyData_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTreeRingToPolyData.vtkTreeRingToPolyData_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeRingToPolyData_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTreeRingToPolyData NewInstance()
		{
			vtkTreeRingToPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeRingToPolyData.vtkTreeRingToPolyData_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeRingToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeRingToPolyData_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeRingToPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkTreeRingToPolyData vtkTreeRingToPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeRingToPolyData.vtkTreeRingToPolyData_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeRingToPolyData = (vtkTreeRingToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeRingToPolyData.Register(null);
				}
			}
			return vtkTreeRingToPolyData;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeRingToPolyData_SetSectorsArrayName_08(HandleRef pThis, string name);

		public virtual void SetSectorsArrayName(string name)
		{
			vtkTreeRingToPolyData.vtkTreeRingToPolyData_SetSectorsArrayName_08(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeRingToPolyData_SetShrinkPercentage_09(HandleRef pThis, double _arg);

		public virtual void SetShrinkPercentage(double _arg)
		{
			vtkTreeRingToPolyData.vtkTreeRingToPolyData_SetShrinkPercentage_09(base.GetCppThis(), _arg);
		}
	}
}
