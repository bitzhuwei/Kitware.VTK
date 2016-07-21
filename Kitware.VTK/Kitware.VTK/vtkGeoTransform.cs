using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoTransform : vtkAbstractTransform
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoTransform";

		public new static readonly string MRClassNameKey;

		static vtkGeoTransform()
		{
			vtkGeoTransform.MRClassNameKey = "class vtkGeoTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoTransform"));
		}

		public vtkGeoTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoTransform New()
		{
			vtkGeoTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTransform.vtkGeoTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoTransform.vtkGeoTransform_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTransform_GetDestinationProjection_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGeoProjection GetDestinationProjection()
		{
			vtkGeoProjection vtkGeoProjection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTransform.vtkGeoTransform_GetDestinationProjection_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoProjection = (vtkGeoProjection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoProjection.Register(null);
				}
			}
			return vtkGeoProjection;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTransform_GetSourceProjection_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGeoProjection GetSourceProjection()
		{
			vtkGeoProjection vtkGeoProjection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTransform.vtkGeoTransform_GetSourceProjection_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoProjection = (vtkGeoProjection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoProjection.Register(null);
				}
			}
			return vtkGeoProjection;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTransform_InternalTransformPoint_03(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkGeoTransform.vtkGeoTransform_InternalTransformPoint_03(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTransform_Inverse_04(HandleRef pThis);

		public override void Inverse()
		{
			vtkGeoTransform.vtkGeoTransform_Inverse_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTransform_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoTransform.vtkGeoTransform_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTransform_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoTransform.vtkGeoTransform_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTransform_MakeTransform_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTransform.vtkGeoTransform_MakeTransform_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTransform_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoTransform NewInstance()
		{
			vtkGeoTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTransform.vtkGeoTransform_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTransform_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoTransform SafeDownCast(vtkObjectBase o)
		{
			vtkGeoTransform vtkGeoTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTransform.vtkGeoTransform_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoTransform = (vtkGeoTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoTransform.Register(null);
				}
			}
			return vtkGeoTransform;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTransform_SetDestinationProjection_11(HandleRef pThis, HandleRef dest);

		public void SetDestinationProjection(vtkGeoProjection dest)
		{
			vtkGeoTransform.vtkGeoTransform_SetDestinationProjection_11(base.GetCppThis(), (dest == null) ? default(HandleRef) : dest.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTransform_SetSourceProjection_12(HandleRef pThis, HandleRef source);

		public void SetSourceProjection(vtkGeoProjection source)
		{
			vtkGeoTransform.vtkGeoTransform_SetSourceProjection_12(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTransform_TransformPoints_13(HandleRef pThis, HandleRef src, HandleRef dst);

		public override void TransformPoints(vtkPoints src, vtkPoints dst)
		{
			vtkGeoTransform.vtkGeoTransform_TransformPoints_13(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis(), (dst == null) ? default(HandleRef) : dst.GetCppThis());
		}
	}
}
