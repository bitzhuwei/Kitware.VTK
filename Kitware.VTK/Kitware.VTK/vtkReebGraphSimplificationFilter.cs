using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkReebGraphSimplificationFilter : vtkDirectedGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkReebGraphSimplificationFilter";

		public new static readonly string MRClassNameKey;

		static vtkReebGraphSimplificationFilter()
		{
			vtkReebGraphSimplificationFilter.MRClassNameKey = "class vtkReebGraphSimplificationFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkReebGraphSimplificationFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkReebGraphSimplificationFilter"));
		}

		public vtkReebGraphSimplificationFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraphSimplificationFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReebGraphSimplificationFilter New()
		{
			vtkReebGraphSimplificationFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraphSimplificationFilter.vtkReebGraphSimplificationFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReebGraphSimplificationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkReebGraphSimplificationFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkReebGraphSimplificationFilter.vtkReebGraphSimplificationFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraphSimplificationFilter_GetOutput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkReebGraph GetOutput()
		{
			vtkReebGraph vtkReebGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraphSimplificationFilter.vtkReebGraphSimplificationFilter_GetOutput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReebGraph = (vtkReebGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReebGraph.Register(null);
				}
			}
			return vtkReebGraph;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkReebGraphSimplificationFilter_GetSimplificationThreshold_02(HandleRef pThis);

		public virtual double GetSimplificationThreshold()
		{
			return vtkReebGraphSimplificationFilter.vtkReebGraphSimplificationFilter_GetSimplificationThreshold_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReebGraphSimplificationFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkReebGraphSimplificationFilter.vtkReebGraphSimplificationFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReebGraphSimplificationFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkReebGraphSimplificationFilter.vtkReebGraphSimplificationFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraphSimplificationFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkReebGraphSimplificationFilter NewInstance()
		{
			vtkReebGraphSimplificationFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraphSimplificationFilter.vtkReebGraphSimplificationFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReebGraphSimplificationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraphSimplificationFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReebGraphSimplificationFilter SafeDownCast(vtkObjectBase o)
		{
			vtkReebGraphSimplificationFilter vtkReebGraphSimplificationFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraphSimplificationFilter.vtkReebGraphSimplificationFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReebGraphSimplificationFilter = (vtkReebGraphSimplificationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReebGraphSimplificationFilter.Register(null);
				}
			}
			return vtkReebGraphSimplificationFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReebGraphSimplificationFilter_SetSimplificationMetric_08(HandleRef pThis, HandleRef metric);

		public void SetSimplificationMetric(vtkReebGraphSimplificationMetric metric)
		{
			vtkReebGraphSimplificationFilter.vtkReebGraphSimplificationFilter_SetSimplificationMetric_08(base.GetCppThis(), (metric == null) ? default(HandleRef) : metric.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReebGraphSimplificationFilter_SetSimplificationThreshold_09(HandleRef pThis, double _arg);

		public virtual void SetSimplificationThreshold(double _arg)
		{
			vtkReebGraphSimplificationFilter.vtkReebGraphSimplificationFilter_SetSimplificationThreshold_09(base.GetCppThis(), _arg);
		}
	}
}
