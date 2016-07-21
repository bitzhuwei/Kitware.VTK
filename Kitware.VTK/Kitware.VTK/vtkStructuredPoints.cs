using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredPoints : vtkImageData
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredPoints";

		public new static readonly string MRClassNameKey;

		static vtkStructuredPoints()
		{
			vtkStructuredPoints.MRClassNameKey = "class vtkStructuredPoints";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredPoints"));
		}

		public vtkStructuredPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredPoints New()
		{
			vtkStructuredPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPoints.vtkStructuredPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStructuredPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStructuredPoints.vtkStructuredPoints_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredPoints_GetDataObjectType_01(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkStructuredPoints.vtkStructuredPoints_GetDataObjectType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredPoints_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredPoints.vtkStructuredPoints_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredPoints_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredPoints.vtkStructuredPoints_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPoints_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredPoints NewInstance()
		{
			vtkStructuredPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPoints.vtkStructuredPoints_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPoints_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredPoints SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPoints.vtkStructuredPoints_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	}
}
