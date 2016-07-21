using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkReebGraphSimplificationMetric : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkReebGraphSimplificationMetric";

		public new static readonly string MRClassNameKey;

		static vtkReebGraphSimplificationMetric()
		{
			vtkReebGraphSimplificationMetric.MRClassNameKey = "class vtkReebGraphSimplificationMetric";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkReebGraphSimplificationMetric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkReebGraphSimplificationMetric"));
		}

		public vtkReebGraphSimplificationMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraphSimplificationMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReebGraphSimplificationMetric New()
		{
			vtkReebGraphSimplificationMetric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReebGraphSimplificationMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkReebGraphSimplificationMetric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkReebGraphSimplificationMetric_ComputeMetric_01(HandleRef pThis, HandleRef mesh, HandleRef field, long startCriticalPoint, HandleRef vertexList, long endCriticalPoint);

		public virtual double ComputeMetric(vtkDataSet mesh, vtkDataArray field, long startCriticalPoint, vtkAbstractArray vertexList, long endCriticalPoint)
		{
			return vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_ComputeMetric_01(base.GetCppThis(), (mesh == null) ? default(HandleRef) : mesh.GetCppThis(), (field == null) ? default(HandleRef) : field.GetCppThis(), startCriticalPoint, (vertexList == null) ? default(HandleRef) : vertexList.GetCppThis(), endCriticalPoint);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkReebGraphSimplificationMetric_GetLowerBound_02(HandleRef pThis);

		public virtual double GetLowerBound()
		{
			return vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_GetLowerBound_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkReebGraphSimplificationMetric_GetUpperBound_03(HandleRef pThis);

		public virtual double GetUpperBound()
		{
			return vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_GetUpperBound_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkReebGraphSimplificationMetric_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkReebGraphSimplificationMetric_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraphSimplificationMetric_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkReebGraphSimplificationMetric NewInstance()
		{
			vtkReebGraphSimplificationMetric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReebGraphSimplificationMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraphSimplificationMetric_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReebGraphSimplificationMetric SafeDownCast(vtkObjectBase o)
		{
			vtkReebGraphSimplificationMetric vtkReebGraphSimplificationMetric = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReebGraphSimplificationMetric = (vtkReebGraphSimplificationMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReebGraphSimplificationMetric.Register(null);
				}
			}
			return vtkReebGraphSimplificationMetric;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkReebGraphSimplificationMetric_SetLowerBound_09(HandleRef pThis, double _arg);

		public virtual void SetLowerBound(double _arg)
		{
			vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_SetLowerBound_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkReebGraphSimplificationMetric_SetUpperBound_10(HandleRef pThis, double _arg);

		public virtual void SetUpperBound(double _arg)
		{
			vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_SetUpperBound_10(base.GetCppThis(), _arg);
		}
	}
}
