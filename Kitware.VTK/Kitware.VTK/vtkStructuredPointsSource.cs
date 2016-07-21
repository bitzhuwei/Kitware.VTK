using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredPointsSource : vtkSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredPointsSource";

		public new static readonly string MRClassNameKey;

		static vtkStructuredPointsSource()
		{
			vtkStructuredPointsSource.MRClassNameKey = "class vtkStructuredPointsSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredPointsSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredPointsSource"));
		}

		public vtkStructuredPointsSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsSource_GetOutput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkStructuredPoints GetOutput()
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsSource.vtkStructuredPointsSource_GetOutput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsSource_GetOutput_02(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkStructuredPoints GetOutput(int idx)
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsSource.vtkStructuredPointsSource_GetOutput_02(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredPointsSource_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredPointsSource.vtkStructuredPointsSource_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredPointsSource_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredPointsSource.vtkStructuredPointsSource_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsSource_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredPointsSource NewInstance()
		{
			vtkStructuredPointsSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsSource.vtkStructuredPointsSource_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsSource_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredPointsSource SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredPointsSource vtkStructuredPointsSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsSource.vtkStructuredPointsSource_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPointsSource = (vtkStructuredPointsSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPointsSource.Register(null);
				}
			}
			return vtkStructuredPointsSource;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredPointsSource_SetOutput_07(HandleRef pThis, HandleRef output);

		public void SetOutput(vtkStructuredPoints output)
		{
			vtkStructuredPointsSource.vtkStructuredPointsSource_SetOutput_07(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}
	}
}
