using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStrahlerMetric : vtkTreeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStrahlerMetric";

		public new static readonly string MRClassNameKey;

		static vtkStrahlerMetric()
		{
			vtkStrahlerMetric.MRClassNameKey = "class vtkStrahlerMetric";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStrahlerMetric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStrahlerMetric"));
		}

		public vtkStrahlerMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStrahlerMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStrahlerMetric New()
		{
			vtkStrahlerMetric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStrahlerMetric.vtkStrahlerMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStrahlerMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStrahlerMetric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStrahlerMetric.vtkStrahlerMetric_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkStrahlerMetric_GetMaxStrahler_01(HandleRef pThis);

		public virtual float GetMaxStrahler()
		{
			return vtkStrahlerMetric.vtkStrahlerMetric_GetMaxStrahler_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStrahlerMetric_GetNormalize_02(HandleRef pThis);

		public virtual int GetNormalize()
		{
			return vtkStrahlerMetric.vtkStrahlerMetric_GetNormalize_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStrahlerMetric_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStrahlerMetric.vtkStrahlerMetric_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStrahlerMetric_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStrahlerMetric.vtkStrahlerMetric_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStrahlerMetric_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStrahlerMetric NewInstance()
		{
			vtkStrahlerMetric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStrahlerMetric.vtkStrahlerMetric_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStrahlerMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStrahlerMetric_NormalizeOff_07(HandleRef pThis);

		public virtual void NormalizeOff()
		{
			vtkStrahlerMetric.vtkStrahlerMetric_NormalizeOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStrahlerMetric_NormalizeOn_08(HandleRef pThis);

		public virtual void NormalizeOn()
		{
			vtkStrahlerMetric.vtkStrahlerMetric_NormalizeOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStrahlerMetric_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStrahlerMetric SafeDownCast(vtkObjectBase o)
		{
			vtkStrahlerMetric vtkStrahlerMetric = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStrahlerMetric.vtkStrahlerMetric_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStrahlerMetric = (vtkStrahlerMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStrahlerMetric.Register(null);
				}
			}
			return vtkStrahlerMetric;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStrahlerMetric_SetMetricArrayName_10(HandleRef pThis, string _arg);

		public virtual void SetMetricArrayName(string _arg)
		{
			vtkStrahlerMetric.vtkStrahlerMetric_SetMetricArrayName_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStrahlerMetric_SetNormalize_11(HandleRef pThis, int _arg);

		public virtual void SetNormalize(int _arg)
		{
			vtkStrahlerMetric.vtkStrahlerMetric_SetNormalize_11(base.GetCppThis(), _arg);
		}
	}
}
