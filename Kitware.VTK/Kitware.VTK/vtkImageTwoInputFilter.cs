using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageTwoInputFilter : vtkImageMultipleInputFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageTwoInputFilter";

		public new static readonly string MRClassNameKey;

		static vtkImageTwoInputFilter()
		{
			vtkImageTwoInputFilter.MRClassNameKey = "class vtkImageTwoInputFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageTwoInputFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageTwoInputFilter"));
		}

		public vtkImageTwoInputFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTwoInputFilter_GetInput1_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetInput1()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageTwoInputFilter.vtkImageTwoInputFilter_GetInput1_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTwoInputFilter_GetInput2_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetInput2()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageTwoInputFilter.vtkImageTwoInputFilter_GetInput2_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageTwoInputFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageTwoInputFilter.vtkImageTwoInputFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageTwoInputFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageTwoInputFilter.vtkImageTwoInputFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTwoInputFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageTwoInputFilter NewInstance()
		{
			vtkImageTwoInputFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageTwoInputFilter.vtkImageTwoInputFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageTwoInputFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTwoInputFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageTwoInputFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageTwoInputFilter vtkImageTwoInputFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageTwoInputFilter.vtkImageTwoInputFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageTwoInputFilter = (vtkImageTwoInputFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageTwoInputFilter.Register(null);
				}
			}
			return vtkImageTwoInputFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageTwoInputFilter_SetInput1_07(HandleRef pThis, HandleRef input);

		public virtual void SetInput1(vtkImageData input)
		{
			vtkImageTwoInputFilter.vtkImageTwoInputFilter_SetInput1_07(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageTwoInputFilter_SetInput2_08(HandleRef pThis, HandleRef input);

		public virtual void SetInput2(vtkImageData input)
		{
			vtkImageTwoInputFilter.vtkImageTwoInputFilter_SetInput2_08(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
