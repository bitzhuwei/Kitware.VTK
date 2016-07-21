using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSpatialRepresentationFilter : vtkPolyDataSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpatialRepresentationFilter";

		public new static readonly string MRClassNameKey;

		static vtkSpatialRepresentationFilter()
		{
			vtkSpatialRepresentationFilter.MRClassNameKey = "class vtkSpatialRepresentationFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpatialRepresentationFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpatialRepresentationFilter"));
		}

		public vtkSpatialRepresentationFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSpatialRepresentationFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSpatialRepresentationFilter New()
		{
			vtkSpatialRepresentationFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpatialRepresentationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSpatialRepresentationFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSpatialRepresentationFilter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSpatialRepresentationFilter_GetLevel_02(HandleRef pThis);

		public virtual int GetLevel()
		{
			return vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_GetLevel_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSpatialRepresentationFilter_GetOutput_03(HandleRef pThis, int level, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyData GetOutput(int level)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_GetOutput_03(base.GetCppThis(), level, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSpatialRepresentationFilter_GetOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyData GetOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_GetOutput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSpatialRepresentationFilter_GetSpatialRepresentation_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLocator GetSpatialRepresentation()
		{
			vtkLocator vtkLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_GetSpatialRepresentation_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLocator = (vtkLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLocator.Register(null);
				}
			}
			return vtkLocator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSpatialRepresentationFilter_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSpatialRepresentationFilter_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSpatialRepresentationFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSpatialRepresentationFilter NewInstance()
		{
			vtkSpatialRepresentationFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpatialRepresentationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSpatialRepresentationFilter_ResetOutput_10(HandleRef pThis);

		public void ResetOutput()
		{
			vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_ResetOutput_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSpatialRepresentationFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSpatialRepresentationFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSpatialRepresentationFilter vtkSpatialRepresentationFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpatialRepresentationFilter = (vtkSpatialRepresentationFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpatialRepresentationFilter.Register(null);
				}
			}
			return vtkSpatialRepresentationFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSpatialRepresentationFilter_SetInput_12(HandleRef pThis, HandleRef input);

		public virtual void SetInput(vtkDataSet input)
		{
			vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_SetInput_12(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSpatialRepresentationFilter_SetSpatialRepresentation_13(HandleRef pThis, HandleRef arg0);

		public virtual void SetSpatialRepresentation(vtkLocator arg0)
		{
			vtkSpatialRepresentationFilter.vtkSpatialRepresentationFilter_SetSpatialRepresentation_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
