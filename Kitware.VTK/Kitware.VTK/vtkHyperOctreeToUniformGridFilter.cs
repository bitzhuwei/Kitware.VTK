using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHyperOctreeToUniformGridFilter : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperOctreeToUniformGridFilter";

		public new static readonly string MRClassNameKey;

		static vtkHyperOctreeToUniformGridFilter()
		{
			vtkHyperOctreeToUniformGridFilter.MRClassNameKey = "class vtkHyperOctreeToUniformGridFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperOctreeToUniformGridFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperOctreeToUniformGridFilter"));
		}

		public vtkHyperOctreeToUniformGridFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeToUniformGridFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeToUniformGridFilter New()
		{
			vtkHyperOctreeToUniformGridFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeToUniformGridFilter.vtkHyperOctreeToUniformGridFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeToUniformGridFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHyperOctreeToUniformGridFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHyperOctreeToUniformGridFilter.vtkHyperOctreeToUniformGridFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeToUniformGridFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHyperOctreeToUniformGridFilter.vtkHyperOctreeToUniformGridFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeToUniformGridFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHyperOctreeToUniformGridFilter.vtkHyperOctreeToUniformGridFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeToUniformGridFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHyperOctreeToUniformGridFilter NewInstance()
		{
			vtkHyperOctreeToUniformGridFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeToUniformGridFilter.vtkHyperOctreeToUniformGridFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeToUniformGridFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeToUniformGridFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeToUniformGridFilter SafeDownCast(vtkObjectBase o)
		{
			vtkHyperOctreeToUniformGridFilter vtkHyperOctreeToUniformGridFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeToUniformGridFilter.vtkHyperOctreeToUniformGridFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctreeToUniformGridFilter = (vtkHyperOctreeToUniformGridFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctreeToUniformGridFilter.Register(null);
				}
			}
			return vtkHyperOctreeToUniformGridFilter;
		}
	}
}
